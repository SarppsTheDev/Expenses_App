import React from 'react';
import SignInPage from './components/SignInPage';
import SignUpPage from './components/SignUpPage';
import { BrowserRouter, Switch, Route, Redirect } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';
import HomePage from './components/HomePage';
import { userAuthenticated } from './app/authenticationSlice';
import { useEffect } from 'react';
import NavBar from './components/NavBar';

const App = () => {
  const {isLoggedIn} = useSelector(state => state.authenticationSlice);
  const dispatch = useDispatch();

  useEffect(() => {
     const token = sessionStorage.getItem('token');
     if(token !== undefined && token !== null){
      dispatch(userAuthenticated({token}));
     }
  }, []);

  return <BrowserRouter>
  <NavBar />
  <Switch>
    <Route exact path='/' render={() => (isLoggedIn ? <HomePage /> : <SignInPage />)} />
    <Route exact path='/signup' render={() => (isLoggedIn ? <Redirect to='/' /> : <SignUpPage />)} />
    <Route exact path='/signin' render={() => (isLoggedIn ? <Redirect to='/' /> : <SignInPage />)} />
    <Route Component={() => <h2>Page not found!</h2>} />
  </Switch>
  
  </BrowserRouter>
}
export default App;
