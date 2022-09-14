var fs = require('fs');
var path = require('path');
var express = require('express');
var app = express();

app.get('/', function(req, res) {
    var filename = req.query.filename;
    var data = req.query.data;
    fs.writeFile(path.join(__dirname, filename), data, function(err) {
        if (err) {
            res.send('Error');
        } else {
            res.send('Success');
        }
    });
})

app.listen(3000);
