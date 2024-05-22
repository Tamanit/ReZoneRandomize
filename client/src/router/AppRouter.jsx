import React, {useContext} from 'react';
import Header from "../component/PagePart/Header";
import {Redirect, Route, Switch} from "react-router-dom";
import {routes, publicRoutes} from "./routes";
import Footer from "../component/PagePart/Footer";
import {AuthContext} from "../context/authContext";

const AppRouter = () => {
    let {jwt, setJwt} = useContext(AuthContext);
    return (
        (jwt !== null) ?
            <div>
                <Header/>
                <Switch>
                    {routes.map(route => <Route
                        key={route.path}
                        path={route.path}
                        component={route.component}
                        exact={route.exact}
                    />)}
                    <Redirect to={routes[0].path}/>
                </Switch>
                <Footer/>
            </div>
            :
            <div>
                <Switch>
                    {publicRoutes.map(route => <Route
                        key={route.path}
                        path={route.path}
                        component={route.component}
                        exact={route.exact}
                    />)}
                    <Redirect to={publicRoutes[0].path}/>
                </Switch>
            </div>
    );
};

export default AppRouter;