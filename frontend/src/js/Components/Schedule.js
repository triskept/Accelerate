export default function Schedule(schedule) {
    return `
    <div id='external-events'>
    <p>
      <strong>Draggable Events</strong>
    </p>
    <div class='fc-event'>My Event 1</div>
    <div class='fc-event'>My Event 2</div>
    <div class='fc-event'>My Event 3</div>
    <div class='fc-event'>My Event 4</div>
    <div class='fc-event'>My Event 5</div>
    <p>
      <input type='checkbox' id='drop-remove' />
      <label for='drop-remove'>remove after drop</label>
    </p>
  </div>
  
  <div id='calendar-container'>
    <div id='calendar'></div>
  </div>    
    `
}