import "./Persist.scss"
import {Computer} from "../Computer/Computer";
import {ajax} from "rxjs/ajax";
import {useEffect} from "react";

export function Persist() {
    useEffect(() => {
        console.log("hello")
        const observable = ajax.getJSON("gateway");
        observable.subscribe((data) => {
            console.log(data);
        })
    }, [])
    return (
        <section>
            <div className={"upper"}>
                <div className={"block"}><img src={"images/server.svg"}/></div>
                <div className={"block"}><img src={"images/server.svg"}/></div>
            </div>
            <div className={"block"}>
                <Computer/>
            </div>
        </section>
    )
}
