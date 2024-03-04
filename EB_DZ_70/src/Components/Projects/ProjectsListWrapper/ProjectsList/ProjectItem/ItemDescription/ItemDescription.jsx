import React from "react";

export const ItemDescription = ({ name, address }) =>
{
    return (
        <div className="item-description">
            <div className="item-name">{name}</div>
            <div className="item-address">{address}</div>
        </div>
    )
}