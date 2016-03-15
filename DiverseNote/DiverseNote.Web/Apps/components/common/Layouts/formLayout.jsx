"use strict";
var React = require('react');
var NavigationBar = require('../Layouts/LayoutComponents/navigationBar.jsx');
var Footer = require('../Layouts/LayoutComponents/footer.jsx');
var PageTitle = require('../Layouts/LayoutComponents/pageTitle.jsx');

var FormLayout = React.createClass({
    propTypes: {
        pageTitle: React.PropTypes.string,
        content: React.PropTypes.element.isRequired
    },

    render: function () {

        var titleBar;
        if (this.props.pageTitle !== undefined)
            titleBar = (<PageTitle page={this.props.pageTitle} />);

        return (
            <div className="container forms-container">
                <div className="row">
                    <div className="col-xs-12 col-sm-12 col-md-12"><NavigationBar /></div>
                </div>
                <div className="row">
                        <div className="col-xs-12 col-sm-12 col-md-12">{titleBar}</div>
                </div>
                    <div className="row">
                         <div className="col-xs-12 col-sm-12 col-md-12">{this.props.content}</div>
                </div>
                 <div className="row">
                    <div className="col-xs-12 col-sm-12 col-md-12"><Footer /></div>
                 </div>
            </div>
            );
    }
});

module.exports = FormLayout;