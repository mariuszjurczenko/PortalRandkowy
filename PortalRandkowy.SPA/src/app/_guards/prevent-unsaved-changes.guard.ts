import { CanDeactivate } from '@angular/router';
import { UserEditComponent } from '../users/user-edit/user-edit.component';

export class PreventUnsavesChanges implements CanDeactivate<UserEditComponent> {
    canDeactivate(component: UserEditComponent) {
        if (component.editForm.dirty) {
            return confirm('Jesteś pewien, że chcesz kontynułować? Wszelkie niezapisane zmiany zostaną utracone');
        }
        return true;
    }
}
