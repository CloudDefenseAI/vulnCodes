var http = require('http');
var url = require('url');
var fs = require('fs');

http.createServer(function (req, res) {
    var q = url.parse(req.url, true);
    var filename = "." + q.pathname;
    var referer = req.headers.referer;
    var host = req.headers.host;
    if (referer && referer.indexOf(host) != -1) {
        fs.readFile(filename, function(err, data) {
            if (err) {
                res.writeHead(404, {'Content-Type': 'text/html'});
                return res.end("404 Not Found");
            }
            res.writeHead(200, {'Content-Type': 'text/html'});
            res.write(data);
            return res.end();
        });
    } else {
        res.writeHead(404, {'Content-Type': 'text/html'});
        return res.end("404 Not Found");
    }
}
).listen(8080);
