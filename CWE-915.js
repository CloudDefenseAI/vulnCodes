var http = require('http');
var url = require('url');
var querystring = require('querystring');

var server = http.createServer(function(req, res) {
    var url_parts = url.parse(req.url, true);
    var query = url_parts.query;
    var obj = { foo: 'bar', csrfHash: 'EER3DS123DS4', email: 'jhon@example.com' };
    var result = obj[query['key']];
    res.end(result);
});

server.listen(8000);
