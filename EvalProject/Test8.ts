//Disclaimer: I have never used TS before today, so most of the solution had to be googled, which was not really easy either, but at least I got the wanted result

function subtract(modifier: number) {
    console.log("subtract(): preformed");
    return function (targetClass: any, propertyKey: string, descriptor: TypedPropertyDescriptor<() => void>) {
        const method = descriptor.value;

        descriptor.value = function (...args: any[]) {        
            const params = args.map(a => JSON.stringify(a)).join();
            const result = method.apply(this, args);
            const r = JSON.stringify(result);
            const modifiedResult = result - modifier;            
            return modifiedResult;
        }

    }
}

function multiply(modifier: number) {
    console.log("multiply(): preformed");
    return function (targetClass: any, propertyKey: string, descriptor: TypedPropertyDescriptor<() => void>) {
        const method = descriptor.value;

        descriptor.value = function (...args: any[]) {        
            const params = args.map(a => JSON.stringify(a)).join();           
            const result = method.apply(this, args);            
            const r = JSON.stringify(result);
            const modifiedResult = result * modifier;
            return modifiedResult;
        }

    }
}

class MathClass {
    @subtract(1)      // TypeScript signals TS1241 here
    @multiply(2)      // but not there
    addOne(number:number) { return number+1; }
}

console.log(new MathClass().addOne(2)) 