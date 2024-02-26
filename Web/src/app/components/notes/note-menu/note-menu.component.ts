import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { faBriefcase, faLayerGroup, faShareAlt, faTag, faAdd } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-note-menu',
  templateUrl: './note-menu.component.html',
  styleUrls: ['./note-menu.component.css']
})
export class NoteMenuComponent {

  public faBriefcase = faBriefcase;
  public faLayerGroup = faLayerGroup;
  public faShareAlt = faShareAlt;
  public faTag = faTag;
  public faAdd = faAdd;
  public selectedLabel = "all";

  constructor(private router: Router) { }

  async ngOnInit(): Promise<void> {

  }

  onLinkClick(label: string): void {
    if (label === "new") {
      this.router.navigate(["note"]);
      return;
    }
    this.selectedLabel = label;
    this.router.navigate(["notes", label]);
    return;
  }
}
