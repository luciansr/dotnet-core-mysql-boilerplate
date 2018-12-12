import React, { Component } from 'react';

import './App.css';
import AppRouter from './routing/AppRouter';

class App extends Component {
  render() {
    return (
      <div className="App">
        <AppRouter></AppRouter>
      </div>
    );
  }
}

export default App;
