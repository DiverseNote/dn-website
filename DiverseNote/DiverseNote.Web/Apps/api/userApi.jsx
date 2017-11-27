"use strict";

var UserApi = {
    registerUser: function () {
        return $.post("example.php", function () {
            alert("success");
        });
    }
}