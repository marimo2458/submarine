// This file was generated by typhen-api

package submarine

import (
	"errors"
)

var _ = errors.New

// PingObject is kind of a TyphenAPI type.
type PingObject struct {
	Message string `codec:"message"`
}

// Coerce the fields.
func (t *PingObject) Coerce() error {
	return nil
}
