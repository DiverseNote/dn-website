"use strict";
var React = require('react');

var Footer = React.createClass({
    render: function () {
        return (
                <div>
                    <nav className="navbar navbar-default navbar-fixed-bottom">
                      <div className="container">
                          <div className="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                              <ul className="nav navbar-nav nav-links navbar-right">
                                <li className="navbar-btn"><a className="nav-link" href="#">About</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">Services</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">Terms of Service</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">FAQs</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">Contact</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">Press Releases</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#/register">Pricing</a></li>
                              </ul>
                          </div>
                      </div>
                    </nav>
                </div>
            );
    }
});

module.exports = Footer;
