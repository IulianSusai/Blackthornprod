﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActivable {
	void Activate(RoomTemplate roomRef);
	void Deactivate();
}
