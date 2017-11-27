"use strict";
var React = require('react');

var NavigationBar = React.createClass({
    render: function () {
        return (
                <div>
                    <nav className="navbar">
                      <div className="container">
                        <div className="navbar-header">
                            <a href="#"><img src="Images/DN_LogoTag-small.png" /></a>                       
                        </div>
                          <div className="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                              <ul className="nav navbar-nav nav-links navbar-right">                                
                                <li className="navbar-btn"><a className="nav-link" href="#/candidatesearch">Find Candidates</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#">Companies</a></li> 
                                <li className="navbar-btn"><a className="nav-link" href="#">Colleges</a></li> 
                                <li className="navbar-btn"><a className="nav-link" href="#">Mentoring</a></li>
                                <li className="navbar-btn"><a className="nav-link" href="#/register">Register</a></li>
                              </ul>
                          </div>
                      </div>
                    </nav>
                </div>
            );
    }
});

module.exports = NavigationBar;