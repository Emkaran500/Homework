import React from "react";
import { ProjectsList } from "./ProjectsList/ProjectsList";
import { ListSwitch } from "./ListSwitch/LsitSwitch";

export const ProjectsListWrapper = () =>
{
    return (
        <div className="projects-list-wrapper">
            <ProjectsList/>
            <ListSwitch/>
        </div>
    )
}