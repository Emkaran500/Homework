import React from "react";
import { ProjectsMenuItem } from "./ProjectsMenuItem/ProjectsMenuItem";

export const ProjectsMenu = () =>
{
    return (
        <ul className="projects-menu">
            <ProjectsMenuItem label={'All'}/>
            <ProjectsMenuItem label={'Commercial'}/>
            <ProjectsMenuItem label={'Residential'}/>
            <ProjectsMenuItem label={'Other'}/>
        </ul>
    )
}