import {envParams} from "../envParams";

export const download = () => {
    let link = document.createElement("a");
    link.href = (new envParams()).DOMAIN + "/api/v1/office/export/";
    link.setAttribute("download", "export.xlsx");
    document.body.appendChild(link);
    link.click();
}
