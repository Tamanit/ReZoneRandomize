import React from "react";
import style from "../../style/PagePart/NaviBar.module.css"
import NavButton from "../UI/NavButton";

let NaviBar = () => {

    return (
        <nav>
            <ul className={style.list}>
                <NavButton
                    to="/"
                    content="Главная"
                />
                <NavButton
                    to="/boardGames"
                    content="Настольные игры"
                />
                <NavButton
                    to="/statistic"
                    content="Статистика"
                />
            </ul>
        </nav>
    )
}

export default NaviBar;
