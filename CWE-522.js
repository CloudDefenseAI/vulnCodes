app.post('/api/users/change-password', function(req, res) {
    const session = req.session;
    const userId = session.userId;
    var password = req.body.password;
    var user = app.models.user;
    user.ChangePassword(userId, password, function(err, result) {
        if (err) {
            res.status(500).send(err);
        } else {
            res.send({
                message: 'Password changed successfully',
                result: result
            });
        }
    });
})
