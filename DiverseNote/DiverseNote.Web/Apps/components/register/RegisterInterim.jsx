"use strict";
var React = require('react');
var FormLayout = require('../Common/Layouts/formLayout.jsx');

var RegisterInterim = React.createClass({

    render: function () {

        var registerInterim = (<div className="container">               
                <div className="row">
                    <div className="col-xs-12 col-sm-8 col-md-8 col-md-offset-2">
                        <form>
                            <p>
                            <h4>To complete your registration, please verify your email address.</h4>
                                We emailed a link to you. Please check your email and click the link to verify
                                your email address. Once verified, you’ll be able to sign in to your account.
                                Please note that you'll have 24 hours to use this link before it expires.
                            <h4>Having trouble?</h4>
                                <a href="#/Registration">Change email address</a><br />
                                <a href="#/Registration">Resend verification email</a><br />
                                <a href="#/Registration">I never got the email</a><br />
                            </p>
                        </form>
                    </div>
                </div>
            </div>);

        return (
                 <FormLayout content={registerInterim} />
            );
}
});

module.exports = RegisterInterim;
                
            