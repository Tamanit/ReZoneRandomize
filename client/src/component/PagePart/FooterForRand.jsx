import React from "react";
import style from "../../style/PagePart/FooterForRand.module.css"
import rezoneLogo from "../../asset/Rezonelogo.svg"

let FooterForRand = () => {

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

export default FooterForRand;
