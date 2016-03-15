"use strict";
var React = require('react');

var PageTitle = React.createClass({
    render: function () {
        return (
               <div className="page-header">
                    <h1>{this.props.page}</h1>                    
                </div>
            );
    }
});

module.exports = PageTitle;

