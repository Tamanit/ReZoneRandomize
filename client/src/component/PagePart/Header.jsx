import React, {useContext} from "react";
import style from "../../style/PagePart/Header.module.css";
import logo from "../../asset/HeaderLogo.svg"
import NaviBar from "./NaviBar";
import AccountButtonBar from "./AccountButtonBar";
import {AuthContext} from "../../context/authContext";


export let Header = () => {
    return (
        <div>
            <div
                className={style.header}
            ></div>
            <header className={`${style.header} ${style.headerFixed}`}>
                <img
                    className={style.img}
                    src={logo}
                    alt="Лого в хеддере"
                />
                <NaviBar/>
                <AccountButtonBar/>
            </header>
        </div>
    );
}

export default Header;
