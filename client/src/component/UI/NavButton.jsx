import React from "react";
import style from "../../style/UI/NavButton.module.css"
import {NavLink} from "react-router-dom";

let NaviBar = (props) => {

    return (
        <li>
            <NavLink className={style.item} to={props.to}>{props.content}</NavLink>
        </li>
    )
}

export default NaviBar;