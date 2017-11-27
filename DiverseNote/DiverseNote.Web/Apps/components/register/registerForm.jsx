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
                            <TextBox id="emailInput" label="Email Address" inputType="email" />
                            <Button id="submitRegistrationInput" label="Create Account" route="#/RegisterInterim" />
                </form>
              </div>
           </div>
            
            )
    }
});

module.exports = RegisterForm;