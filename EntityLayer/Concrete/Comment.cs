﻿namespace EntityLayer.Concrete;

public class Comment
{
    public int CommentId { get; set; }
    public string CommentUser { get; set; }
    public DateTime CommentDate { get; set; }
    public string CommentContent { get; set; }
    public bool CommentState { get; set; }
    public int DestinationID { get; set; }
    public Destination Destination { get; set; }
}