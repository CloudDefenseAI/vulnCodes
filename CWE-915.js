var http = require('http');
var url = require('url');
var querystring = require('querystring');

var server = http.createServer(function(req, res) {
    var url_parts = url.parse(req.url, true);
    var query = url_parts.query;
    const allowedKeys = ['foo', 'email']
    var obj = { foo: 'bar', csrfHash: 'EER3DS123DS4', email: 'jhon@example.com' };
    if (allowedKeys.includes(query['key'])) {
        var result = obj[query['key']];
        res.end(result);
    }else {
        res.end('Invalid key');
    }
});

server.listen(8000);
