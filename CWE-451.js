var modal = document.createElement("div");
modal.setAttribute("class", "modal fade");
modal.setAttribute("id", "myModal");
modal.setAttribute("role", "dialog");
modal.setAttribute("tabindex", "-1");
modal.setAttribute("aria-labelledby", "myModalLabel");
modal.setAttribute("aria-hidden", "true");
modal.setAttribute("data-backdrop", "static");
modal.setAttribute("data-keyboard", "false");
modal.innerHTML = `
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="myModalLabel">You received a image from one of your friend!</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <p>Are you sure you want to download Camera_selfie.png image ?</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancel</button>
                <button type="button" class="btn btn-primary" id="download">Download</button>
            </div>
        </div>
    </div>
`;
document.body.appendChild(modal);
