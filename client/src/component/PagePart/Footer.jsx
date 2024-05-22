import React from "react";
import style from "../../style/PagePart/Footer.module.css"
import rezoneLogo from "../../asset/Rezonelogo.svg"

let Footer = () => {

    return (
        <footer className={style.footer}>
            <img
                className={style.img}
                src={rezoneLogo}
                alt="Лого резоны"
            />
        </footer>
    )
}

export default Footer;
