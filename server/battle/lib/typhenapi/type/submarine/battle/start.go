// This file was generated by typhen-api

package battle

import (
	"errors"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi"
)

var _ = errors.New

// Start is a kind of TyphenAPI type.
type Start struct {
	StartedAt int64 `json:"started_at" msgpack:"started_at"`
}

// Coerce the fields.
func (t *Start) Coerce() error {
	return nil
}

// Bytes creates the byte array.
func (t *Start) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}
