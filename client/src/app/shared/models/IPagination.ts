import { IProduct } from "./IProduct";

type Nullable<T> = T | null;

export interface IPagination {
    pageIndex: number;
    pageSize: number;
    count:     number;
    data:      IProduct[];
}
