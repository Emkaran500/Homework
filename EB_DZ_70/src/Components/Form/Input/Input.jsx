import React from "react";

export const Input = ({ style, type, placeholder }) =>
{
    return (
        <input style={style} className="form-input" type={type} placeholder={placeholder}></input>
    )
}