"use strict";

var React = require('react');
var TextBox = require('../Common/InputControls/textbox.jsx');
var Button = require('../Common/InputControls/button.jsx');
var RegisterForm = React.createClass({
    render: function () {

        return (
            <div className="panel panel-default panel-register">
                <div className="panel-heading">
                <h3 className="panel-title">Sign Up for DiverseNote</h3>
                </div>
              <div className="panel-body">
                <form>
                            <TextBox id="firstNameInput" label="First Name" inputType="text" />
                            <TextBox id="lastNameInput" label="Last Name" inputType="text" />
                            <TextBox id="userNameInput" label="User Name" inputType="text" />
                            <TextBox id="passwordInput" label="Password" inputType="password" />
                            <Button id="submitRegistrationInput" label="Create Account" route="#/CandidateRegister" />
                </form>
              </div>
           </div>
            
            )
    }
});

module.exports = RegisterForm;