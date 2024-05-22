import React from "react";
import style from "../../style/UI/Button.module.css"
import {NavLink} from "react-router-dom";

let Button = (props) => {

    return (
        <NavLink
            className={style.button}
         to={props.to}
        >
            {props.content}
        </NavLink>
    )
}

export default Button;
