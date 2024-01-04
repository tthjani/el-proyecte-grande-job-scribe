const { createProxyMiddleware } = require('http-proxy-middleware');

module.exports = function(app) {
  app.use(
    '/api',
    createProxyMiddleware({
      target: process.env.EXAMPLE_BACKEND_URL || 'http://localhost:5225/',
      changeOrigin: true,
    })
  );
};