import { Angular5Csv } from 'angular5-csv/Angular5-csv';

export class csvConvertorService {

    private options = {
        fieldSeparator: ',',
        quoteStrings: '"',
        decimalseparator: '.',
        showLabels: true,
        showTitle: false,
        useBom: true,
        noDownload: false,
        headers: []
    };

    /*
    public getMycsv (MyData:MyData[]){
        
        this.options.headers= this.getProperty(MyData[0]) ;
        new Angular5Csv(MyData, "MyData",  this.options);
    }
    */
}