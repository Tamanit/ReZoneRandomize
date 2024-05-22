import React, {useState} from "react";
import style from "../style/App.module.css";
import {BrowserRouter} from "react-router-dom";
import AppRouter from "./AppRouter";
import {AuthContext} from "../context/authContext";

let App = () => {
    let [jwt, setJwt] = useState(null);
    return (
        <AuthContext.Provider value={
            {jwt, setJwt}
        }>
            <div className={style.app}>
                <BrowserRouter>
                    <AppRouter/>
                </BrowserRouter>
            </div>
        </AuthContext.Provider>
    )
}

export default App;
