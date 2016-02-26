"use strict";

var React = require('react');
//var Link = require('react-router-component').Link;

var Button = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        size: React.PropTypes.string,
        route: React.PropTypes.string
    },

    render: function () {
        var control;
        //TODO: this should include an event property.  execute the event then navigate
            if(this.props.route !== undefined)
                control = (<a className="btn btn-primary" href={this.props.route}>{this.props.label}</a>);
            else
                control = (<button type="button" class="btn btn-primary">{this.props.label}</button>);
        
            return (control);
}
});

module.exports = Button;