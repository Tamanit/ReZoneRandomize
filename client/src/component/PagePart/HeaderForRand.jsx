import React, {useContext} from "react";
import style from "../../style/PagePart/HeaderForRand.module.css";
import logo from "../../asset/HeaderLogo.svg"


export let HeaderForRand = () => {
    return (
        <div>
            <header className={`${style.header} ${style.headerFixed}`}>
                <img
                    className={style.img}
                    src={logo}
                    alt="Лого в хеддере"
                />
            </header>
        </div>
    );
}

export default HeaderForRand;
