import React, {useContext, useState} from 'react';
import Input from "../UI/Input";
import style from "./../../style/Page/Login.module.css"
import Button from "../UI/Button";
import {AuthContext} from "../../context/authContext";
import {sendRequestToLogin} from "../../controller/UserController";
import {useHistory} from "react-router-dom";
import RedirectButton from "../UI/RedirectButton";

const Login = () => {
    let {jwt, setJwt} = useContext(AuthContext);
    let router = useHistory();

    let [notAuth ,setNotAuth] = useState('Привее!');
    let [login, setLogin] = useState('');
    let [password, setPassword] = useState('');

    let logIn = async () => {
        let token = await sendRequestToLogin(login, password);
        if (token !== '') {

            setJwt(token);
        } else {
            setNotAuth('Логин и пароль неверны');
        }
    }


    return (
        <div className={style.page}>
            <div className={style.wrapper}>
                <p>Вход</p>
                <p>{notAuth}</p>
                <Input
                    name="Логин"
                    value={login}
                    onChange={setLogin}

                />
                <Input
                    name="Пароль"
                    type="password"
                    value={password}
                    onChange={setPassword}
                />

                <Button
                    content="Войти"
                    action={logIn}
                />
                <p></p>
                <p></p>
                <p></p>
                <RedirectButton
                    to="register"
                    content="Зарегестрироваться"
                />
            </div>
        </div>
    );
};

export default Login;
