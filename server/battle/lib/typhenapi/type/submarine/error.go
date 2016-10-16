// This file was generated by typhen-api

package submarine

import (
	"errors"
	"fmt"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi/core"
)

var _ = errors.New

// Error is a kind of TyphenAPI type.
type Error struct {
	Code    int64  `codec:"code"`
	Name    string `codec:"name"`
	Message string `codec:"message"`
}

// Coerce the fields.
func (t *Error) Coerce() error {
	return nil
}

// Error returns the error message.
func (t *Error) Error() string {
	return fmt.Sprintf("Code: %v, Name: %v, Message: %v", t.Code, t.Name, t.Message)
}

// Bytes creates the byte array.
func (t *Error) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}