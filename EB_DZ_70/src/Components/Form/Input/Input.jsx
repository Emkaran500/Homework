import React from "react";

export const Input = ({ type, placeholder }) =>
{
    return (
        <input className="form-input" type={type} placeholder={placeholder}></input>
    )
}