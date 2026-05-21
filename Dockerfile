FROM nginx:alpine

COPY build/WebGL /usr/share/nginx/html

# Unity WebGL requires specific MIME types and headers
RUN echo 'server { \
    listen 80; \
    root /usr/share/nginx/html; \
    location / { \
        add_header Cross-Origin-Opener-Policy "same-origin"; \
        add_header Cross-Origin-Embedder-Policy "require-corp"; \
        try_files $uri $uri/ /index.html; \
    } \
    location ~* \\.gz$ { \
        add_header Content-Encoding gzip; \
    } \
    types { \
        application/wasm wasm; \
        application/javascript js; \
    } \
}' > /etc/nginx/conf.d/default.conf

EXPOSE 80
