var http = require('http');
var url = require('url');
var querystring = require('querystring');

var host = 'localhost';
var port = 8080;

http.get(options, function(res) {
    res.on('data', function(data) {
        console.log(data.toString());
    });
});

http.createServer(function(req, res) {
    const user_id = req.query.user_id;
    var path = '/api/v1/query?query=';
    var query = 'select * from users where user_id = ' + user_id;
    var options = {
        host: host,
        port: port,
        path: path + querystring.escape(query)
    };

    var query = url.parse(req.url, true).query;
    if (query.query) {
        console.log(query.query);
    }
    res.end();
}).listen(8080);
