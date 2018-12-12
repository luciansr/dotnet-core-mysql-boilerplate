import React from "react";
import { HashRouter as Router, Route, Link, Redirect } from "react-router-dom";

import Index from '../index/Index';

const Login = () => <div>
  <h2>Login</h2>
  <Link to="/index">Home</Link>
</div>;

const AppRouter = () => (
  <Router>
    <div>
      {/* <Redirect exact from="/" to="login" /> */}
      <Route path="/index" component={Index} />
      <Route path="/login" component={Login} />
    </div>
  </Router>
);

export default AppRouter;