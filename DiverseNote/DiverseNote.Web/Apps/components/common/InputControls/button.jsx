"use strict";

var React = require('react');
//var Link = require('react-router-component').Link;

var Button = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        onclick: React.PropTypes.func,
        size: React.PropTypes.string,
        route: React.PropTypes.string
    },

    render: function () {
        var control;
        //TODO: this should include an event property.  execute the event then navigate
            if(this.props.route !== undefined)
                control = (<a className="btn btn-primary" href={this.props.route}>{this.props.label}</a>);
            else
                control = (
                <div className="form-group"><button type="button" className="btn btn-primary" onClick={this.props.onclick }>{this.props.label}</button>
                </div>);
        
            return (control);
}
});

module.exports = Button;