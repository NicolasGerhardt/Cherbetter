/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { AddTicketComponent } from './add-ticket.component';

let component: AddTicketComponent;
let fixture: ComponentFixture<AddTicketComponent>;

describe('add-ticket component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ AddTicketComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(AddTicketComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});