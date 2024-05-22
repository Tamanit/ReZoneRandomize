import React, {useContext} from 'react';
import style from "../../style/PagePart/AccountButtonBar.module.css"
import Button from "../UI/Button";
import profileImg from "../../asset/ProfilePictore.svg"
import logOut from "../../asset/LogoutImage.svg"
import {AuthContext} from "../../context/authContext";

const AccountButtonBar = () => {

    const {jwt, setJwt} = useContext(AuthContext);
    let disposeToken = () => {
        setJwt(null);
    }
    return (
        <div className={style.box}>
            <Button
                content={
                    <img
                        className={style.img}
                        src={profileImg}
                        alt="Профиль"
                    />
                }
            />
            <Button
                content={
                    <img
                        className={style.img}
                        src={logOut}
                        alt="выход"
                    />
                }
                action={disposeToken}
            />
        </div>
    );
};

export default AccountButtonBar;