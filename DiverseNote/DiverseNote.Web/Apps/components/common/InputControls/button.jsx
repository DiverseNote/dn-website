"use strict";

var React = require('react');
var Button = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        onclick: React.PropTypes.func,
        size: React.PropTypes.string,
        route: React.PropTypes.string,
        submit: React.PropTypes.string
    },

    render: function () {
        var control;
        //TODO: remove this and use window.redirect or react routing
        if (this.props.route !== undefined)
            control = (<div className="form-group"><a className="btn btn-primary" href={this.props.route}>{this.props.label}</a></div>);
        else {
            var buttonType;
            var submit = this.props.submit;
            if (submit !== undefined && submit !== null && submit === "true")
                buttonType = 'submit';
            else
                buttonType = 'button';
            
            control = (
                <div className="form-group"><button type={buttonType} className="btn btn-primary" align="right" onClick={this.props.onclick}>{this.props.label}</button>
                </div>);
        }
        return (control);
}
});

module.exports = Button;