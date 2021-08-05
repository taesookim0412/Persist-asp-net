import "./Persist.scss"
import {Computer} from "../Computer/Computer";

export function Persist() {
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
