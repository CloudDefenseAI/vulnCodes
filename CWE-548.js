http.createServer(function (req, res) {
    var q = url.parse(req.url, true);
    var filename = "." + q.pathname;
    var ext = path.extname(filename);
    var allowedExtensions = ['.jpg', '.jpeg', '.png', '.gif'];
    if (allowedExtensions.indexOf(ext) > -1) {
        fs.readFile(filename, function(err, data) {
            if (err) {
                res.writeHead(404, {'Content-Type': 'text/html'});
                return res.end("404 Not Found");
            }
            res.writeHead(200, {'Content-Type': 'image/jpeg'});
            res.write(data);
            return res.end();
        });
    } else {
        res.writeHead(403, {'Content-Type': 'text/html'});
        return res.end("403 Forbidden");
    }
}).listen(8080);
