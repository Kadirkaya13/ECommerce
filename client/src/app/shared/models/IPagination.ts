import { IProduct } from "./IProduct";

type Nullable<T> = T | null;

export interface IPagination {
    pageIndex: Nullable<number>;
    pagesSize: Nullable<number>;
    count:     Nullable<number>;
    data:      IProduct[];
}
