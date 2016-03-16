"use strict";
var React = require('react');
var RegisterForm = require('./registerForm.jsx');
var FormLayout = require('../Common/Layouts/formLayout.jsx');

var Register = React.createClass({


    render: function () {

        var register = (<div className="container">               
                <div className="row">
                    <div className="col-xs-12 col-sm-8 col-md-8 col-md-offset-2"><RegisterForm /></div>
                </div>
            </div>);

        return (
                 <FormLayout content={register} />
            );
    }
});

module.exports = Register;