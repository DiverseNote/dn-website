"use strict";
var React = require('react');
var Banner = require('./banner.jsx');
var NavigationBar = require('../Common/Layouts/LayoutComponents/navigationBar.jsx');
var Footer = require('../Common/Layouts/LayoutComponents/footer.jsx');

var Landing = React.createClass({
    render: function () {
        return (
                    <div className="container-fluid landing-container">
                        <div className="row landing-row">
                            <div className="col-xs-12 col-sm-12 col-md-12"><NavigationBar /></div>
                        </div>
                        <div className="row landing-row">
                            <div className="col-xs-12 col-sm-12 col-md-12"><Banner /></div>
                        </div>
                        <div className="row">
                    <div className="col-xs-12 col-sm-12 col-md-12"><Footer /></div>
                        </div>
                    </div>
            );
    }
});

module.exports = Landing;