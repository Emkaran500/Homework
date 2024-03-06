import React from "react";

export const MessageBox = ({ style, type, placeholder }) =>
{
    return (
        <textarea style={style} className="form-input" type={type} placeholder={placeholder}></textarea>
    )
}