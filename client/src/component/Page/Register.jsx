import React, {useContext, useState} from 'react';
import Input from "../UI/Input";
import style from "./../../style/Page/Login.module.css"
import Button from "../UI/Button";
import {AuthContext} from "../../context/authContext";
import {sendRequestToLogin, setRequestFromRegister} from "../../controller/UserController";
import {useHistory} from "react-router-dom";
import RedirectButton from "../UI/RedirectButton";

const Login = () => {
    let {jwt, setJwt} = useContext(AuthContext);

    let [login, setLogin] = useState('');
    let [password, setPassword] = useState('');

    let register = async () => {
        let token = await setRequestFromRegister(login, password);
        if (token !== '') {

            setJwt(token);
        } else {
        }
    }

    return (
        <div className={style.page}>
            <div className={style.wrapper}>
                <p>Регистрация</p>
                <p></p>
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
                    content="Зарегистрироваться"
                    action={register}
                />
                <p></p>
                <p></p>
                <p></p>
                <RedirectButton
                    to="login"
                    content="Войти?"
                />
            </div>
        </div>
    );
};

export default Login;
