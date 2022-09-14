var fs = require('fs');
var path = require('path');

var filePath = path.join(__dirname, req.query.file);
fs.readFile(filePath, function(err, data) {
    if (err) {
        res.send('error');
    } else {
        res.send(data);
    }
}
