import React from "react";
import { ItemDescription } from "./ItemDescription/ItemDescription";

export const ProjectItem = ({ img, name, address }) =>
{
    return (
        <li>
            <div className="project-item">
                <img src={img}/>
                <ItemDescription name={name} address={address}/>
            </div>
        </li>
    )
}